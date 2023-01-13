using System.Collections.Immutable;

namespace Collections.Jack;

public class Part4
{
    public ImmutableList<string> Poem { get; private set; }

    public ImmutableList<string> AddPart(ImmutableList<string> poem)
    {
        Poem = poem.Add("Вот кот,\nКоторый пугает и ловит синицу,\n" +
                        "Которая часто ворует пшеницу,\nКоторая в темном чулане хранится\n" +
                        "В доме,\nКоторый построил Джек.");
        return Poem;
    }
}
