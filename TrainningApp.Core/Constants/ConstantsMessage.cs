using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Core.Constants
{
    public static class ConstantsMessage
    {
    }
    public static class ConstantsMessageTrainning
    {
        public static string ErrorGetById = "Treino não localizado";
        public static string ErrorCreate = "Erro ao criar treino";
        public static string ErrorUserWithoutTrainning = "Usuário não possui treino";
        public static string ErrorTrainningNotByPersonal = "Este treino não foi criado pelo Personal logado";
        public static string ErrorTrainningNotByUser = "Este treino não foi criado para esse usuário.";
    }
    public static class ConstantsMessageTrainningDay
    {
        public static string ErrorGetById = "Treino do dia não localizado";
        public static string ErrorCreate = "Erro ao criar treino do dia";
     
    }
    public static class ConstantsMessageApplicationUser
    {
        public static string ErrorGetById = "Usuário não localizado";
    }

    public static class ConstantsMessageManagement
    {
        public static string Personal = "Personal";
        public static string Student = "Aluno";
        public static string Adm = "Administrador";
        public static string ErrorNotPersonalManagement = "Usuário não é Personal";
        public static string ErrorNotAdmManagement = "Usuário não é Administrador";
        public static string ErrorNotAllowedManagement = "Usuário sem permissão";
    }

    public static class ConstantsMessageTrainningExercise
    {
        public static string ErroFindById = "Erro ao buscar exercicio do treino";

    }

    public static class ConstantsMessageExercise
    {
        public static string ErroFindById = "Erro ao buscar exercicio";

    }

    public static class ConstantsMessageMuscle
    {
        public static string ErroFindByName = "Erro ao buscar músculo";

    }
}
