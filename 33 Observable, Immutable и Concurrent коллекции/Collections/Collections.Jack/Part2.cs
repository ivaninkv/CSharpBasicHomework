using System.Collections.Immutable;

namespace Collections.Jack;

public class Part2
{
    public ImmutableList<string> Poem { get; private set; }

    public ImmutableList<string> AddPart(ImmutableList<string> poem)
    {
        Poem = poem.Add("А это пшеница,\nКоторая в темном чулане хранится\n" +
                        "В доме,\nКоторый построил Джек.");
        return Poem;
    }
}
