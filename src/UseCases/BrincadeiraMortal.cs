namespace SaveRian.UseCases
{
    public static class BrincadeiraMortal
    {
        public static int RetornaPosicaoSegura(int totalParticipantes)
        {
            if(totalParticipantes <= 1)
                return totalParticipantes;

            var potencia = 1;
            var ultimaPotenciadeDois = 0;
            while(potencia <= totalParticipantes)
            {
                if( (potencia*=2) < totalParticipantes) 
                {
                    ultimaPotenciadeDois = potencia;
                }
                else if (potencia == totalParticipantes)
                {
                    return 1;
                }

            }

            int restoPotenciaTotalParticipantes = totalParticipantes - ultimaPotenciadeDois;

            return (2*restoPotenciaTotalParticipantes)+1;
        }
    }
}