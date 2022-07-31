public class Solution {
    public static Main(string[] args)
    {
        Console.WriteLine(CanConstruct("aa", "baba"));
    }
    
    // C# Dictionary Docs
    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
    public static bool CanConstruct(string ransomNote, string magazine) {
        // cannot make ransomNote from magazine if it doesn't have enough letters
        if (magazine.Length < ransomNote.Length)
        {
            return false;
        }
        
        int len = ransomNote.Length;
        Dictionary<char, int> noteDict = new Dictionary<char, int>();
        Dictionary<char, int> magDict = new Dictionary<char, int>();

        AddToDict(noteDict, ransomNote);
        AddToDict(magDict, magazine);

        // check if there is enough of each letter to form the note 
        foreach (char letter in noteDict.Keys)
        {
            if (!magDict.ContainsKey(letter))
            {
                return false;
            }
            else if (noteDict[letter] > magDict[letter])
            {
                return false;
            }
        }
        
        return true;
    }
    
    public static void AddToDict(Dictionary<char, int> dict, string src)
    {
        foreach (char letter in src)
        {
            if (!dict.TryAdd(letter, 1))
            {
                dict[letter]++;
            }
        }
        
    }
}