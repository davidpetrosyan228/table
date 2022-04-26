using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Table.Model;
using Table.Model.Entity;

namespace Table.View
{
    /// <summary>
    /// Логика взаимодействия для TablePage.xaml
    /// </summary>
    public partial class TablePage : Page
    {
        public TablePage()
        {
            InitializeComponent();
            
            List<DayType> dayTypes = new List<DayType>();
            List<WeekType> weekTypes = new List<WeekType>();
            List<Class> classes = new List<Class>();
            ObservableCollection<LessonAtDayModel> lessons;
            lessons = new ObservableCollection<LessonAtDayModel>();
            using (var context = new TableCollegeEntities())
            {
                classes = context.Class.ToList();
                weekTypes = context.WeekType.ToList();
                dayTypes = context.DayType.ToList();
                GroupBox.ItemsSource = classes;
                GroupBox.DisplayMemberPath = "className";
                DaysBox.ItemsSource = dayTypes;
                DaysBox.DisplayMemberPath = "Type";
                WeekBox.ItemsSource = weekTypes;
                WeekBox.DisplayMemberPath = "Description";

                foreach (var item in context.LessonsAtDay)
                {
                    lessons.Add(LessonAtDayModel.GetModelFromDb(item));
                }


            }

        }

        private void GroupBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        if (GroupBox.SelectedIndex != -1 && WeekBox.SelectedIndex != -1 && DaysBox.SelectedIndex != -1)
        {
                using (var context = new TableCollegeEntities())
                {
                    var mama = context.LessonsAtDay.Where(exp => exp.ClassId == (GroupBox.SelectedItem as Class).Id && exp.WeekId == (WeekBox.SelectedItem as WeekType).Id && exp.DayId == (DaysBox.SelectedItem as DayType).Id).ToList();

                    Table.ItemsSource = mama;
                }
            }
        }
    }
}
