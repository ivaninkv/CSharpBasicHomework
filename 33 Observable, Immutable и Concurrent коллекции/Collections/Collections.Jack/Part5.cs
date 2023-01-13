using System.Collections.Immutable;

namespace Collections.Jack;

public class Part5
{
    public ImmutableList<string> Poem { get; private set; }

    public ImmutableList<string> AddPart(ImmutableList<string> poem)
    {
        Poem = poem.Add("Вот пес без хвоста,\nКоторый за шиворот треплет кота,\n" +
                        "Который пугает и ловит синицу,\nКоторая часто ворует пшеницу,\n" +
                        "Которая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
        return Poem;
    }
}
