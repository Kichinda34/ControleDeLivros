using ControleDeLivros;

internal class Program
{
    private static void Main(string[] args)
    {
        string file;

        Book book = CreateBook();

        WriteFile(book);
        
        Console.Clear();

        Console.WriteLine("Informe o nome do arquivo: ");
        file = Console.ReadLine();

        var texto = ReadFile(file);

        Console.WriteLine(texto);

        Book CreateBook()
        {
            Console.Write("informe o titulo do Livro: ");
            var titulo = Console.ReadLine();

            Console.Write("\ninforme o Autor do livro: ");
            var autor = (Console.ReadLine());

            Console.Write("\ninforme o Código de ISBN do livro: ");
            var codigoIdentificacao = (Console.ReadLine());


            return new Book(titulo, autor, codigoIdentificacao);
        }

        void WriteFile(Book book)
        {
            try
            {
                var texto = ReadFile("Books.txt");
                StreamWriter sw = new StreamWriter("Books.txt");
                sw.WriteLine(texto + book.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Livro registrado com sucesso!!");
                Thread.Sleep(1000);
            }

        }

        string ReadFile(string file)
        {
            try
            {
                StreamReader sr = new StreamReader(file);
                var text = sr.ReadToEnd();
                sr.Close();
                return text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("arquivo nao encontrado");
            }
            return "";
        }
    }
}