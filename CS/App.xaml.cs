using DataAnnotationAttributes.Model;
using System.Data.Entity;
using System.Windows;

namespace DataAnnotationAttributes {
    public partial class App: Application {
        protected override void OnStartup(StartupEventArgs e) {
            Database.SetInitializer<ContactContext>(new ContactContextInitializer());
            base.OnStartup(e);
        }
    }
}
