﻿using System.IO;
using Bounce.Framework;
using Candidate.Core.Log;
using Candidate.Core.Settings.Model;
using Candidate.Core.Setup;
using Candidate.Core.Utils;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.Web.Administration;
using NUnit.Framework;

namespace Candidate.Tests.Integration {
    [TestFixture]
    public class RunSetupTests {

        private static string CurrentDirectory = Directory.GetCurrentDirectory();
        private static DirectoryProvider DirectoryProvider = new DirectoryProvider("RunSetupTestsJob", CurrentDirectory);

        [SetUp]
        public void Setup() {
            UnzipTestSolution();
        }

        [TearDown]
        public void Teardown() {
            DeleteTestFolder();
        }

        [Test]
        public void SetupWithOutGitHub_ShouldBuild() {
            // arrange
            var config = new JobConfigurationModel() {
                Solution = new SolutionModel {
                    Name = "TestSolution\\Test.sln"
                },
            };

            var targetsRetriever = new TargetsRetriever();

            var configObjectBuilder = new ConfigObjectBuilder(DirectoryProvider);
            var targetsObjectBuilder = new DefaultTargetsObjectBuilder(targetsRetriever, configObjectBuilder);

            var targetsBuilder = new TargetsBuilder();

            var bounceFactory = new BounceFactory();

            // act
            var defaultSetup = new DefaultSetup(targetsObjectBuilder, targetsBuilder, bounceFactory);
            defaultSetup.RunForConfig(new DummyLogger(), config);

            // assert
            Assert.That(Directory.Exists(DirectoryProvider.Source + "TestSolution\\Test\\bin"));
        }

        [Test]
        public void OutputShouldGoToLogger() {
            // arrange
            var config = new JobConfigurationModel() {
                Solution = new SolutionModel {
                    Name = "TestSolution\\Test.sln"
                },
            };

            var targetsRetriever = new TargetsRetriever();

            var configObjectBuilder = new ConfigObjectBuilder(DirectoryProvider);
            var targetsObjectBuilder = new DefaultTargetsObjectBuilder(targetsRetriever, configObjectBuilder);

            var targetsBuilder = new TargetsBuilder();
            var bounceFactory = new BounceFactory();

            // act
            var loggerFactory = new LoggerFactory();
            var loggerId = "";
            using (var logger = loggerFactory.CreateLogger(DirectoryProvider.Logs)) {
                loggerId = logger.Id;

                var defaultSetup = new DefaultSetup(targetsObjectBuilder, targetsBuilder, bounceFactory);
                defaultSetup.RunForConfig(logger, config);
            }

            // assert
            Assert.That(File.Exists(loggerId), Is.True);
            Assert.That(File.ReadAllText(loggerId), Is.Not.Empty);
        }

        [Test]
        public void ShouldBeAbleToDeployIisSite() {
            // arrange
            var config = new JobConfigurationModel() {
                Solution = new SolutionModel {
                    Name = "TestSolution\\Test.sln",
                    WebProject = "Test"
                },
                Iis = new IisModel {
                    SiteName = "TestSite"
                }
            };

            var targetsRetriever = new TargetsRetriever();

            var configObjectBuilder = new ConfigObjectBuilder(DirectoryProvider);
            var targetsObjectBuilder = new DefaultTargetsObjectBuilder(targetsRetriever, configObjectBuilder);

            var targetsBuilder = new TargetsBuilder();
            var bounceFactory = new BounceFactory();

            // act
            var defaultSetup = new DefaultSetup(targetsObjectBuilder, targetsBuilder, bounceFactory);
            defaultSetup.RunForConfig(new DummyLogger(), config);

            // assert
            var iisServer = new ServerManager();
            Assert.That(iisServer.Sites["TestSite"], Is.Not.Null);
        }

        private void UnzipTestSolution() {
            DeleteTestFolder();
            new FastZip().ExtractZip("TestData\\TestSolution.zip", DirectoryProvider.Source, null);
        }

        private void DeleteTestFolder() {
            if (Directory.Exists(DirectoryProvider.Job)) {
                Directory.Delete(DirectoryProvider.Job, true);
            }
        }

    }
}