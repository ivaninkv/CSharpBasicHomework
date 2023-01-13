using System.Collections.Immutable;

namespace Collections.Jack;

public class Part8
{
    public ImmutableList<string> Poem { get; private set; }

    public ImmutableList<string> AddPart(ImmutableList<string> poem)
    {
        Poem = poem.Add("А это ленивый и толстый пастух,\nКоторый бранится с коровницей строгою,\n" +
                        "Которая доит корову безрогую,\nЛягнувшую старого пса без хвоста,\n" +
                        "Который за шиворот треплет кота,\nКоторый пугает и ловит синицу,\n" +
                        "Которая часто ворует пшеницу,\nКоторая в темном чулане хранится\n" +
                        "В доме,\nКоторый построил Джек.");
        return Poem;
    }
}
