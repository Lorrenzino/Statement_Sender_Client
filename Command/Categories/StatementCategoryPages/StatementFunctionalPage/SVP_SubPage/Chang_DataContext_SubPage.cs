using System.Collections.ObjectModel;
using Statement_Sender_Client.ViewModel.Categories.Statements;
using Statement_Sender_Client.ViewModel.Categories.Statements.StatementSub;

namespace Statement_Sender_Client.Command.Categories.StatementCategoryPages.StatementFunctionalPage.SVP_SubPage
{
    internal class Chang_DataContext_SubPage : CommandBase
    {
        private ViewModel_MainStatementPage _dc;
        private ObservableCollection<ViewModelStatement> _collect;
        public Chang_DataContext_SubPage(ViewModel_MainStatementPage dc, ObservableCollection<ViewModelStatement> collect)
        {
            _dc= dc;
            _collect= collect;
        }
        public override void Execute(object parameter)
        {
            
        }
    }
}
