namespace LeetCodeProblems;

public class FirstIndexString
{
    public int StrStr(string haystack, string needle) {
        int index = haystack.IndexOf(needle);
        return index;
    }
}