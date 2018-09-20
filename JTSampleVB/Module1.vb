Imports Moraware.JobTrackerAPI5

Module Module1

    Sub Main()
        Const DB = "" ' your DB name here
        Const JTURL = "https://" & DB & ".moraware.net/"
        Const UID = "" ' your UID here - needs to be an administrator or have the API right
        Const PWD = "" ' your PWD here

        ' first, you need a connection
        Dim conn As New Connection(JTURL & "api.aspx", UID, PWD)
        conn.Connect()

        ' get a specific Job
        Dim job = conn.GetJob(456)
        Console.WriteLine("Job {0} is {1}", job.JobName, job.JobStatus)

        conn.Disconnect()
    End Sub

End Module
