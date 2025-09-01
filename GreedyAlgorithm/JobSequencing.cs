namespace Algorithms.GreedyAlgorithm;

public static class JobSequencing
{
    public static (int, int) Find(int N, (int, int, int)[] jobs)
    {
        if (N == 0) return (0, 0);

        List<Job> jobsRecord = [];
        foreach ((int a, int b, int c) in jobs)
        {
            jobsRecord.Add(new Job(a, b, c));
        }

        // sort by deadline
        jobsRecord.Sort((a, b) => b.Profit - a.Profit);

        // find max deadline;
        var maxDeadline = 0;
        foreach (Job j in jobsRecord)
        {
            if (j.Deadline > maxDeadline) maxDeadline = j.Deadline;
        }

        // empty slots
        int[] jobSlots = new int[maxDeadline + 1];
        for(int i = 1; i <= maxDeadline; i++)
        {
            jobSlots[i] = -1;
        }

        int profit = 0;
        var maxJob = 0;
        // find profit
        for (int i = 0; i < N; i++)
        {
            var currentJob = jobsRecord[i];
            for (int j = currentJob.Deadline; j > 0; j--)
            {
                // find slot
                if (jobSlots[j] == -1)
                {
                    jobSlots[j] = currentJob.Id;
                    profit += currentJob.Profit;
                    maxJob += 1;
                    break;
                }
            }
        }

        return (maxJob, profit);
    }

    private record Job(int Id, int Deadline, int Profit);
}