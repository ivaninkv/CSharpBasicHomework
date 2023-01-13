using System.Collections.Immutable;

namespace Collections.Jack;

public class Part3
{
    public ImmutableList<string> Poem { get; private set; }

    public ImmutableList<string> AddPart(ImmutableList<string> poem)
    {
        Poem = poem.Add("А это веселая птица-синица,\nКоторая часто ворует пшеницу," +
                        "\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
        return Poem;
    }
}
