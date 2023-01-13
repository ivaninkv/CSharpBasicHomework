using System.Collections.Immutable;

namespace Collections.Jack;

public class Part9
{
    public ImmutableList<string> Poem { get; private set; }

    public ImmutableList<string> AddPart(ImmutableList<string> poem)
    {
        Poem = poem.Add("Вот два петуха,\nКоторые будят того пастуха,\n" +
                        "Который бранится с коровницей строгою,\nКоторая доит корову безрогую,\n" +
                        "Лягнувшую старого пса без хвоста,\nКоторый за шиворот треплет кота,\n" +
                        "Который пугает и ловит синицу,\nКоторая часто ворует пшеницу,\n" +
                        "Которая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");
        return Poem;
    }
}
