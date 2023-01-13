using System.Collections.Immutable;

namespace Collections.Jack;

public class Part1
{
    public ImmutableList<string> Poem { get; private set; }

    public ImmutableList<string> AddPart(ImmutableList<string> poem)
    {
        Poem = poem.Add("Вот дом,\nКоторый построил Джек.");
        return Poem;
    }
}
