using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultDetails
{

    public class ResultDetail
    {
        public Results results { get; set; }
        public string expand { get; set; }
        public Link2 link { get; set; }
    }

    public class Results
    {
        public int size { get; set; }
        public string expand { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
        public Result[] result { get; set; }
    }

    public class Result
    {
        public string expand { get; set; }
        public Link link { get; set; }
        public Plan plan { get; set; }
        public string planName { get; set; }
        public string projectName { get; set; }
        public string buildResultKey { get; set; }
        public string lifeCycleState { get; set; }
        public int id { get; set; }
        public DateTime buildStartedTime { get; set; }
        public string prettyBuildStartedTime { get; set; }
        public DateTime buildCompletedTime { get; set; }
        public DateTime buildCompletedDate { get; set; }
        public string prettyBuildCompletedTime { get; set; }
        public int buildDurationInSeconds { get; set; }
        public int buildDuration { get; set; }
        public string buildDurationDescription { get; set; }
        public string buildRelativeTime { get; set; }
        public string vcsRevisionKey { get; set; }
        public Vcsrevisions vcsRevisions { get; set; }
        public string buildTestSummary { get; set; }
        public int successfulTestCount { get; set; }
        public int failedTestCount { get; set; }
        public int quarantinedTestCount { get; set; }
        public int skippedTestCount { get; set; }
        public bool continuable { get; set; }
        public bool onceOff { get; set; }
        public bool restartable { get; set; }
        public bool notRunYet { get; set; }
        public bool finished { get; set; }
        public bool successful { get; set; }
        public string buildReason { get; set; }
        public string reasonSummary { get; set; }
        public Artifacts artifacts { get; set; }
        public Comments comments { get; set; }
        public Labels labels { get; set; }
        public Jiraissues jiraIssues { get; set; }
        public Stages stages { get; set; }
        public string key { get; set; }
        public Planresultkey planResultKey { get; set; }
        public string state { get; set; }
        public string buildState { get; set; }
        public int number { get; set; }
        public int buildNumber { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string rel { get; set; }
    }

    public class Plan
    {
        public string shortName { get; set; }
        public string shortKey { get; set; }
        public string type { get; set; }
        public bool enabled { get; set; }
        public Link1 link { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public Plankey planKey { get; set; }
    }

    public class Link1
    {
        public string href { get; set; }
        public string rel { get; set; }
    }

    public class Plankey
    {
        public string key { get; set; }
    }

    public class Vcsrevisions
    {
        public int size { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
    }

    public class Artifacts
    {
        public int size { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
    }

    public class Comments
    {
        public int size { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
    }

    public class Labels
    {
        public int size { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
    }

    public class Jiraissues
    {
        public int size { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
    }

    public class Stages
    {
        public int size { get; set; }
        public int startindex { get; set; }
        public int maxresult { get; set; }
    }

    public class Planresultkey
    {
        public string key { get; set; }
        public Entitykey entityKey { get; set; }
        public int resultNumber { get; set; }
    }

    public class Entitykey
    {
        public string key { get; set; }
    }

    public class Link2
    {
        public string href { get; set; }
        public string rel { get; set; }
    }

}
