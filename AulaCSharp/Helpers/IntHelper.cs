namespace AulaCSharp.Helpers
{
    public static class IntHelper
    {
        public static int AdicionarDigitoVerificador(this int num)
        {
            int primeiro = num / 10;
            int segundo = num % 10;
            int terceiro = (primeiro + segundo) % 10;
            return num * 10 + terceiro;
        }

        public static int ConverterParaInteiro(this string numero)
        {
            if (int.TryParse(numero, out var value))
            {
                return value;
            }

            return 0;
        }
    }
}