namespace Aula11Polimorfismo
{
    public class Calculo
    {
        public string Calcular(){
            return "O personagem não pode fazer um ataque";
        }

        public string Calcular(int dano){
            return "O ataque do personagem tem força de " +dano;
        }
        
        public string Calcular(int fisico, int psicologico){
            int defesa = fisico + psicologico;
            return "A vida do personagem é " +defesa;
        }
    
        public string Calcular(int dano, int escudo, int defesa){
            return "Ao usar o escudo, o ataque ficará mais fraco, mas a defesa aumentará, de forma que o ataque é "+ (dano-escudo)+ " e a defesa é "+(defesa+escudo);           
        }
        public string Calcular(string tipoAtaque, string armaPrincipal){
            return $"O tipo de ataque usado pelo player é {tipoAtaque} e sua arma principal é {armaPrincipal}";
        }
    }
}