namespace GerenciadorDeTarefas
{
    public class Tarefa
    {
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        
        public Tarefa(string descricao)
        {
            Descricao = descricao;
            Concluida = false;
        }

        public void Concluir()
        {
            Concluida = true;
        }

        public string ParaArquivo()
        {
            return $"{Descricao};{Concluida}";
        }

        public override string ToString()
        {
            string status = Concluida ? "[X]" : "[ ]";
            return $"{status} {Descricao}";
        }
    }
}