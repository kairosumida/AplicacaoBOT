using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Bot_Aplicacao.Dialogs
{
    [Serializable]
    [QnAMaker("59e89aba89f24c8aa40d5865d88c3370", "75e8d5b4-77a8-4356-b672-689cf5d81495","I don't understand this right now! Try another query", 0.5, 3)]
    public class qnaDialogActivitLearning : QnAMakerDialog
    {
        
    }
}