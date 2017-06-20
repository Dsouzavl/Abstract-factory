# O padrão _Abstract factory_

## Escrito por Victor Souza A.k.a _vhost_

Bem vindo a fábrica de abstrações, esse padrão nos permite que a construção da instância seja realizada a partir de um ponto de abstração, assim não nos preocupamos com a implementação concreta. Utilizamos esse padrão, para simplificar a criação de múltiplos objetos, cujo suas _factories_ compartilham a mesma abstração. Por exemplo:

Digamos que eu tenha uma fábrica abstrata de **Humanos**, e essa fábrica tem que fabricar cabelos, bocas e pés, que são características de todo humano, mas os humanos não são todos iguais, então eu preciso fabricar um cabelo preto, loiro ou ruivo, uma boca grande ou pequena, isso remete muito ao polimorfismo, a capacidade de um comportamento ter várias faces e várias maneiras de acontecer, no nosso caso, uma fábrica vai fabricar cabelos pretos, boca pequena e pés grande, enquanto outra vai fabricar cabelos loiros, boca grande e pés pequenos, repare que todas as fabricas fabricam o mesmo produto, só que de forma diferente, e estarão todas agrupadas em **Humanos**, nosso padrão serviu para resolver o problema de eu precisar criar vários humanos, que tem a mesma abstração, mas podem ser concretamente diferentes. 

A implementação desse caso, utilizando **C#**, ficaria mais ou menos assim:

```csharp
    public interface IHumano
    {
        Cabelo cabelo();
        Boca boca();
        Pes pes();
    }
```
```csharp
    public class Boca
    {
        public string Tamanho;
    }

    public class Cabelo
    {
        public string Cor;

        public string Tamanho;
    }

    public class Pes
    {
        public string Tamanho;

        public bool TemChule;
    }
```

```csharp
public class ChineseFactory : IHumano
{
    public Boca boca()
    {
        Boca boca = new Boca();
        boca.Tamanho = "Pequena";

        return boca;
    }

    public Pes pes()
    {
        Pes pes = new Pes();
        pes.Tamanho = "Pequeno";
        pes.TemChule = true;

        return pes;
    }

    public Cabelo cabelo()
    {
        Cabelo cabelo = new Cabelo();
        cabelo.Cor = "Preto";
        cabelo.Tamanho = "Curto";

        return cabelo;
    }
}
```
```csharp
public class BrazilianFactory : IHumano
{
    public Boca boca()
    {
        Boca boca = new Boca();
        boca.Tamanho = "Grande";

        return boca;
    }

    public Pes pes()
    {
        Pes pes = new Pes();
        pes.Tamanho = "Grande";
        pes.TemChule = true;

        return pes;
    }

    public Cabelo cabelo()
    {
        Cabelo cabelo = new Cabelo();
        cabelo.Cor = "Castanho";
        cabelo.Tamanho = "Curto";

        return cabelo;
    }
}
```

Observe, que temos uma interface, onde você claramente pode compor um humano com seus métodos, suas implementações concretas conseguem compor **Humanos** de várias formas, mas o ponto de abstração é o mesmo. Conseguimos resolver nosso problema, afinal é para isso que padrões foram feitos, então sempre tente entender qual problema o padrão resolve, simplesmente saber que existe e o que faz não acrescenta nada, se vocÊ não sabe quando deve utilizá-lo.

## Final

Quero agradecer aos meus amigos [Charles Lomboni](https://github.com/charleslomboni)
e [Rodrigo Couto](https://github.com/rscouto) por me ajudarem a entender esse padrão e compor esse artigo.

Obrigado a todos os leitores!