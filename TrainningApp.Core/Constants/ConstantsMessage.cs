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
    {{
        public static string ErrorGetById = "Treino não localizado";
        public static string ErrorCreate = "Erro ao criar treino";
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
}
