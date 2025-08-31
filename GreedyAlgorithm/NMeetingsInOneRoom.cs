using System.Collections;

namespace Algorithms.GreedyAlgorithm;

// Question - https://takeuforward.org/data-structure/n-meetings-in-one-room/
public static class NMeetingInOneRoom
{
    public static (int, int[]) Count(int[] start, int[] end)
    {
        int N = start.Length;
        if (N == 0) return (0, []);
        if (N == 1) return (0, [1]);

        List<Meeting> meetings = [];
        for (int i = 0; i < N; i++)
        {
            meetings.Add(new Meeting(start[i], end[i], i + 1));
        }

        meetings.Sort((a, b) => a.End.CompareTo(b.End));

        List<int> meetingOrder = [meetings[0].Number];
        int freeTime = meetings[0].End;

        for (int i = 1; i < N; i++)
        {
            var meeting = meetings[i];
            if (meeting.Start >= freeTime)
            {
                meetingOrder.Add(meeting.Number);
                freeTime = meeting.End;
            }
        }

        return (meetingOrder.Count, meetingOrder.ToArray());

    }

    private record Meeting(int Start, int End, int Number);
}