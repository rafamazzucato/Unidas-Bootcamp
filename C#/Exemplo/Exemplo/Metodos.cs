namespace Exemplo
{
    static class Metodos
    {
        //Método estático
        public static string RetirarAcentos(this string texto)
        {
            string comAcentos =
            "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos =
            "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(),
                semAcentos[i].ToString());
            }

            return texto;
        }
    }
}