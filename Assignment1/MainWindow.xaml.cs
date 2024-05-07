using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Globalization;
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

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        public MainWindow()
        {
            this.InitializeComponent();

            this.Loaded += MainWindow_Loaded;

            List<Team> teams = GetPremierLeagueTeams();
            // Assign position
            int position = 1;
            foreach (var team in teams)
            {
                team.Position = position++;
            }
            leagueTable.ItemsSource = teams;
            leagueTable.MouseDoubleClick += LeagueTable_MouseDoubleClick;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PlayPremierLeagueThemeSong();
        }

        private void ApplyRowStyle(int rowIndex, Brush color)
        {
            DataGridRow row = (DataGridRow)leagueTable.ItemContainerGenerator.ContainerFromIndex(rowIndex);
            if (row != null)
            {
                row.Background = color;
                row.Foreground = Brushes.White;
            }
        }

        private List<Team> GetPremierLeagueTeams()
        {
            List<Team> teams = new List<Team>
            {
                new Team("Arsenal", 36, 26, 5, 5, 88, 28, new List<string> {"Aaron Ramsdale (G)", "David Raya (G) ", "William Saliba (D)", "Ben White (D)", "Gabriel Magalhaes (D)", "Cedric Soares (D)", "Jurriem Timber (D)", "Jakub Kiwior (D)", "Takeheiro Tomiyasu (D)", "Oleksandr Zinchenko (D)", "Thomas Partey (M)", "Martin Ødegaard (M)", "Emile Smith Rowe (M)", "Jorginho (M)", "Fabio Vieira (M)", "Mohamed Elneny (M)", "Declan Rice (M)", "Ethan Nwaneri (M)", "Bukayo Saka (F)", "Gabriel Jesus (F)", "Gabriel Martinelli (F)", "Eddie Nketiah (F)", "Leandro Trossard (F)", "Reiss Nelson (F)", "Kai Havertz (F)" }, "Mikel Arteta","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Arsenal.png"),
                new Team("Liverpool", 36, 23, 9, 4, 81, 38, new List<string> { "Alisson Becker (G)", "Caoimhin Kelleher (G)", "Joe Gomez (D)", "Virgil Van Dijk (D)", "Ibrahima Konate (D)", "Kostas Tsimikas (D)", "Andrew Robertson (D)", "Joel Matip (D)", "Trent Alexander-Arnold (D)", "Jarell Quansah (D)", "Conor Bradley (D)", "Wataru Endo (M)", "Thiago Alcantara (M)", "Dominik Szoboszlai (M)", "Alexis Mac Allister (M)", "Curtis Jones (M)", "Harvey Elliot (M)", "Ryan Gravenberch (M)", "Luis Diaz (F)", "Darwin Nunez (F)", "Mohammed Salah (F)", "Cody Gakpo (F)", "Diogo Jota (F)", "Jayden Danns (F)" }, "Jurgen Klopp","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Liverpool.png"),
                new Team("Man City", 35, 25, 7, 3, 87, 33, new List<string> { "Stefan Ortega Moreno (G)", "Ederson (G)", "Kyle Walker (D)", "Ruben Dias (D)", "John Stones (D)", "Nathan Ake (D)", "Sergio Gomez (D)", "Josko Gvardiol (D)", "Manuel Akanji (D)", "Rico Lewis (D)", "Mateo Kovacic (M)", "Jack Grealish (M)", "Jeremy Doku (M)", "Rodri (M)", "Kevin De Bruyne (M)", "Bernardo Silva (M)", "Matheus Nunes (M)", "Phil Foden (M)", "Erling Haaland (F)", "Julian Alvarez (F)", "Oscar Bobb (F)" }, "Pep Guardiola", "C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Mancity.png"),
                new Team("Tottenham", 35, 18, 6, 11, 69, 58, new List<string> { "Guglielmo Vicario (G)", "Fraser Forster (G)", "Radu Dragusin (D)", "Emerson Royal (D)", "Cristian Romero (D)", "Ryan Sessegnon (D)", "Pedro Porro (D)", "Ben Davies (D)", "Micky van de Ven (D)", "Destiny Udogie (D)", "Oliver Skipp (M)", "Pierre-Emile Hojbjerg (M)", "Yves Bissouma (M)", "James Maddison (M)", "Bryan Gil (M)", "Timo Werner (M)", "Giovani Lo Celso (M)", "Pape Sarr (M)", "Rodrigo Bentancur (M)", "Son Heung-Min (F)", "Richarlison (F)", "Dejan Kulusevski (F)", "Brennan Johnson (F)", "Manor Solomon (F)"}, "Ange Postecoglu", "C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Spurs.png"),
                new Team("Aston Villa", 36, 20, 6, 11, 69, 58, new List<string> {  "Emiliano Martinez (G)", "Robin Olsen (G)", "James Wright (D)", "Matty Cash (D)", "Diego Carlos (D)", "Ezri Konsa (D)", "Tyrone Mings (D)", "Lucas Digne (D)", "Pau Torres (D)", "Alex Moreno (D)", "Calum Chambers (D)", "Clement Lenglet (D)", "Douglas Luiz (M)", "John McGinn (D)", "Youri Tielemans (M)", "Emiliano Buendia (M)", "Moussa Diaby (M)", "Nicolo Zaniolo (M)", "Bertrand Traore (M)", "Leon Bailey (M)", "Jacob Ramsey (M)", "Boubacar Kamara (M)", "Ollie Watkins (F)", "Keinan Davis (F)"}, "Unai Emery","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Astonvilla.png"),
                new Team("Man United", 34, 16, 6, 12, 52, 51, new List<string> {  "Andre Onana (G)", "Altay Bayindir (G)", "Victor Lindelof (D)", "Harry Maguire (D)", "Lisandro Martinez (D)", "Tyrell Malacia (D)", "Casemiro (M)", "Raphael Varane (D)", "Diogo Dalot (D)", "Luke Shaw (D)", "Aaron Wan-Bissaka (D)", "Jonny Evans (D)", "Sofyan Amraba (M)", "Mason Mount (M)", "Bruno Fernandes (M)", "Marcus Rashford (M)", "Christian Eriksen (M)", "Alejandro Garnacho (M)", "Antony (M)", "Kobbie Mainoo (M)", "Scott Mctominay (M)", "Anthony Martial (F)", "Rasmus Hojlund (F)", "Amad Diallo (F)"}, "Erik Ten Hag", "C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\ManUnited.png"),
                new Team("West Ham", 36, 13, 10, 13, 56, 70, new List<string> {  "Lukasz Fabianski (G)", "Alphonse Areola (G)", "Aaron Cresswell (D)", "Kurt Zouma (D)", "Vladimir Coufal (D)", "Konstantinos Mavropanos (D)", "Angelo Ogbonna (D)", "Nayef Aguerd (D)", "Emerson (D)", "James Word-Prowse (M)", "Lucas Paqueta (M)", "Kavlin Phillips (M)", "Mohammed Kudus (M)", "Edson Alvarez (M)", "Jarrod Bowen (M)", "Tomas Soucek (M)", "Michail Antonio (F)", "Maxwell Cornet (F)", "Danny Ings (F)"}, "David Moyes","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Westham.png"),
                new Team("Newcastle", 35, 17, 5, 13, 78, 56, new List<string> { "Martin Dubravka (G)", "Nick Pope (G)", "Kieran Trippier (D)", "Sven Botman (D)", "Fabian Schar (D)", "Lewis Hall (D)", "Tino Livramento (D)", "Dan Burn (D)", "Sandro Tonali (M)", "Anthony Gordon (M)", "Matt Ritchie (M)", "Jacob Murphy (M)", "Miguel Almiron (M)", "Joe Willock (M)", "Sean Longstaff (M)", "Bruno Guimaraes (M)", "Jamie Miley (M)", "Joelinton (F)", "Callum Wilson (F)", "Alexander Isak (F)", "Harvey Barnes (F)", "Amadou Diallo (F)"}, "Eddie Hearn","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Newcastle.png"),
                new Team("Chelsea", 35, 15, 9, 11, 70, 59, new List<string> {  "Robert Sanchez (G)", "Djordje Petrovi c (G)", "Axel Disasi (D)", "Marc Curella (D)", "Benoit Badiashile (D)", "Thiago Silva (D)", "Trevoh Chalobah (D)", "Ben Chilwell (D)", "Reece James (D)", "Levi Colwill (D)", "Malo Gusto (D)", "Wesley Fofana (D)", "Raheem Sterling (M)", "Enzo Fernandez (M)", "Mykhailo Mudryk (M)", "Noni Madueke (M)", "Carney Chukwuemeka (M)", "Cole Palmer (M)", "Conor Gallagher (M)", "Moises Caicedo (M)", "Romeo Lavia (M)", "Nicola Jackson (F)", "Christopher Nkunku (F)"}, "Maricio Pochettino","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Chelsea.png"),
                new Team("Brighton", 35, 12, 11, 12, 53, 57, new List<string> {  "Bart Verbruggen (G)", "Jason Steele (G)", "Tariq Lamptey (D)", "Adam Webster (D)", "Lewis Dunk (D)", "Jan Paul van Hecke (D) ", "Pervis Estupinan (D)", "Joel Veltman (D)", "James Milner (M)", "Solly March (M)", "Joao Pedro (M)", "Julio Enciso (M)", "Billy Gilmour (M)", "Pascal Gross (M)", "Adam Lallana (M)", "Jakub Moder (M)", "Carlos Baleba (M)", "Kaoru Mitoma (M)", "Danny Welbeck (F)", "Evan Ferguson (F)", "Ansu Fati (F)"}, "Roberto De Zerbi","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Brighton.png"),
                new Team("Wolves", 36, 13, 7, 16, 49, 60, new List<string> {  "Jose Sa (G)", "Daniel Bentley (G)", "Santiago Bueno (D)", "Craig Dawson (D)", "Nelson Semedo (D)", "Max Kilman (D)", "Toti Gomes (D)", "Matt Doherty (M)", "Rayan Ait-Nouri (M)", "Marlo Lemina (M)", "Boubacar Traoure (M)", "Joao Gomes (M)", "Hugo Bueno (M)", "Pablo Sarabia (M)", "Jean-Ricner Bellegarde (M)", "Pedro Neto (F)", "Hwan Hee-Chan (F)", "Matheus Cunha (F)", "Nathan Fraser (F)"}, "Garry O'Neill","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Wolves.png"),
                new Team("Bournemouth", 36, 13, 9, 14, 52, 63, new List<string> { "Neto (G)", "Darren Randolph (G)", "Ryan Fredericks (D)", "Milos Kerkez (D)", "Owen Bevan (D)", "Adam Smith (D)", "James Hill (D)", "Chris Mepham (D)", "James Hill (D)", "Marcos Senesi (D)", "Max Aarons (D)", "Lewis Cook (M)", "Ryan Christie (M)", "Alex Scott (M)", "Marcus Tavernier (M)", "Luis Sinisterra (M)", "Tyler Adams (M)", "Philip Billing (M)", "Dominic Solanke (F)", "Justin Kluivert (F)", "Antoine Semenyo (F)"}, "Andoni Iraola","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Bournemouth.png"),
                new Team("Fulham", 36, 12, 8, 16, 51, 55, new List<string> {  "Marek Rodak (G)", "Bernd Leno (G)", "Antonee Robinson (D)", "Kenny Tete (D)", "Calvin Bassey (D)", "Tim Ream (D)", "Timothy Castagne (D)", "Issa Diop (D)", "Anthony Knockaert (M)", "Harrison Reed (M)", "Harry Wislon (M)", "Tom Cairney (M)", "Bobby De Cordova-Reid (M)", "Andreas Pereira (M)", "Willian (M)", "Alex Iwobi (M)", "Joao Palhinha (M)", "Raul Jimenez (F)", "Armando Broja (F)", "Adama Traore (F)", "Rodrigo Muniz (F)" }, "Marco Silva","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Fulham.png"),
                new Team("Crystal Palace", 35, 10, 10, 15, 45, 57, new List<string> {  "Sam Jonstone (G)", "Dean Henderson (G)", "Joel Ward (D)", "Rob Holding (D)", "Marc Guehi (D)", "Joachin Anderson (D)", "Nathaniel Clyne (D)", "Tyrick Mitchell (D)", "Jefferson Lerma (D)", "Daniel Munoz (M)", "James McArthur (M)", "Adam Wharton (M)", "Cheick Doucoure (M)", "Naouirou Ahamada (M)", "Jairo Riedewald (M)", "Kaden Rodney (M)", "Jadan Raymond (M)", "Michael Olise (F)", "Jordan Ayew (F)", "Eberechi Eze (F)", "Jean-Phillipe Mateta (F)", "Jeffrey Schlupp (F)", "Odsonne Edouard (F)"}, "Oliver Glasner","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\CrystalPalace.png"),
                new Team("Brentford", 36, 9, 9, 18, 52, 60, new List<string> {  "Mark Flekken (G)", "Thomas Strakosha (G)", "Aaron Hickey (D)", "Rico Henry (D)", "Ethan Pinnock (D)", "Sergio Reguilon (D)", "Ben Mee (D)", "Kristoffer Ajer (D)", "Nathan Collins (D)", "Christian Norgaard (M)", "Mathias Jensen (M)", "Frank Obyeka (M)", "Mikkel Damsgaard (M)", "Vitaly Janelt (M)", "Ryan Trevitt (M)", "Shandon Baptiste (M)", "Neal Maupay (F)", "Josh Dasilva (F)", "Yoane Wissa (F)", "Ivan Toney (F)", "Bryan Mbuemo (F)" },"Thomas Frank","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Brentford.jpg"),
                new Team("Everton", 36, 12, 9, 15, 38, 49, new List<string> {  "Jordan Pickford (G)", "Joao Virginia (G)", "Michael Keane (D)", "James Tarkowski (D)", "Ashely Young (D)", "Vitalii Mykolenko (D)", "Ben Godfrey (D)", "Seamus Coleman (D)", "Jarrad Branthwaite (D)", "Dwight McNeil (M)", "Amadou Onana (M)", "Jack Harrison (M)", "Dele Alli (M)", "Andre Gomes (M)", "Idrissa Gueye (M)", "James Garner (M)", "Dominic Calvert-Lewin (F)", "Arnaut Danjuma (F)", "Beto (F)", "Abdoulaye Doucoure (F)" }, "Sean Dyche", "C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Everton.png"),
                new Team("Nottm Forrest", 36, 8, 9, 19, 45, 63, new List<string> {  "Matt Turner (G)", "Wayne Hennessey (G)", "Nuno Tavares (D)", "Neco Williams (D)", "Felipe (D)", "Moussa Niakhate (D)", "Gonzalo Monitiel (D)", "Willy Boly (D)", "Andrew Omobamidele (D)", "Murillo (D)", "Ibrahima Sangare (M)", "Cheikhou Kouyate (M)", "Morgan Gibbs-White (M)", "Callum Hudson-Odoi (N)", "Nicolas Dominguez (M)", "Giovanni Reyna (M)", "Anthony Elanga (M)", "Ryan Yates (M)", "Divock Origi (M)", "Danilo (M)", "Jamie McDonnell (M)", "Taiwo Awoniyi (F)", "Chris Wood (F)", "Rodrigo Ribeiro (F)"}, "Nuno Espirito Santo","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Nottingham.png"),
                new Team("Luton", 36, 6, 8, 22, 49, 78, new List<string> {  "James Shea (G)", "Tim Krul (G)", "Gabriel Osho (D)", "Tom Lockyer (D)", "Mads Andersen (D)", "Christian Chigozie (D)", "Amari'i Bell (D)", "Axel Pielsold (D)", "Ross Barkley (M)", "Luke Barry (M)", "Issa Kabore (M)", "Marvelous Nakamba (M)", "Pelly Ruddock Mpanzu (M)", "Albert Sambi Lokonga (M)", "Fred Onyedinma (M)", "Zack Nelson (M)", "Alfie Doughty (M)", "Jake Burger (M)", "Josh Allen (F)", "Chiedozie Ogbene (F)", "Jacob Brown (F)", "Carlton Morris (F)", "Cauley Woodrow (F)", "Elijah Adebayo (F)", "Tahith Chong (F)", "Andros Townsend (F)" }, "Rob Edwards","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Luton.png"),
                new Team("Burnley", 36, 5, 9, 22, 39, 74, new List<string> {  "James Trafford (G)", "Denis Franchi (D)", "Dara O'Shea (D)", "Charlie Taylor (D)", "Jordan Beyer (D)", "Lorenz Assignon (D)", " Vitinho (D)", "Maxime Esteve (D)", "Hannes Delcroix (D)", "Seb Thompson (M)", "Jack Cork (M)", "Johan Gudmundsson (M)", "Josh Brownhill (M)", "Nathan Redmond (M)", "Sander Berge (M)", "Aaron Ramsey (M)", "Josh Cullen (M)", "Mike Tresor (M)", "Jacob Bruun Larsen (M)", "Han-Noah Massengo (M)", "Jay Rodriguez (F)", "Manuel Benson (F)", "Lyle Foster (F)", "David Datro Fofana (F)", "Zeki Amdouni (F)" }, "Vincent Kompany","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Burnley.jpg"),
                new Team("Sheffield", 36, 3, 7, 26, 35, 100, new List<string> {  "Adam Davies (G)", "Ivo Grbic (G)", "George Baldock (D)", "Max Lowe (D)", "Auston Trusty (D)", "John Egan (D)", "Nickseon Gomis (D)", "Jack Robinson (D)", "Sam Curtis (D)", "Mason Holgate (D)", "Evan Easton (D)", "Gustavo Hamer (M)", "Oliver Norwood (M)", "Jayden Bogle (M)", "Vinicius Souza (M)", "Tom Davies (M)", "Ben Osborn (M)", "Anis Ben SLimane (M)", "Ryan One (M)", "Yasser Larouci (M)", "James McAtee (M)", "Rhian Brewster (F)", "Oli McBurnie (F)", "Cameron Archer (F)", "Ben Brereton (F)" }, "Chris Wilder","C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Sheffield.png"),

            };

            teams = teams.OrderByDescending(t=>t.Points).ToList();
            for (int i = 0; i < teams.Count; i++)
            {
                teams[i].Position = i + 1;
            }
            return teams;
        }
        private void LeagueTable_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dataGrid = sender as DataGrid;
            if (dataGrid != null && dataGrid.SelectedItem != null)
            {
                Team selectedTeam = (Team)dataGrid.SelectedItem;
                ShowTeamInformation(selectedTeam);
            }
        }

        private void ShowTeamInformation(Team team)
        {
            try
            {
                var grid = new Grid();

                // Background Image
                var backgroundImage = new ImageBrush(new BitmapImage(new Uri("C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Images\\Premierleague.png")));
                grid.Background = backgroundImage;

                // ScrollViewer to hold the content
                var scrollViewer = new ScrollViewer
                {
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto, // Show vertical scrollbar when needed
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto // Show horizontal scrollbar when needed
                };

                // DockPanel to hold the content
                var dockPanel = new DockPanel();

                // StackPanel for the left side elements
                var leftStackPanel = new StackPanel
                {
                    Margin = new Thickness(20),
                    VerticalAlignment = VerticalAlignment.Center,
                };

                // Text block for manager information
                var managerTextBlock = new TextBlock
                {
                    Text = $"Manager: {team.Manager}",
                    Foreground = Brushes.White,
                    Margin = new Thickness(0, 0, 0, 10),
                    FontWeight = FontWeights.Bold
                };

                // Text block for player information
                var playersTextBlock = new TextBlock
                {
                    Text = $"Players:\n{string.Join("\n", team.Players)}",
                    Foreground = Brushes.White,
                    TextWrapping = TextWrapping.Wrap,
                    FontWeight = FontWeights.Bold
                };

                // Text block for team statistics
                var statisticsTextBlock = new TextBlock
                {
                    Text = $"Matches Played: {team.MatchesPlayed}\nWins: {team.Wins}\nDraws: {team.Draws}\nLosses: {team.Losses}\nGoals For: {team.GoalsFor}\nGoals Against: {team.GoalsAgainst}\nPoints: {team.Points}",
                    Foreground = Brushes.White,
                    TextWrapping = TextWrapping.Wrap,
                    Margin = new Thickness(0, 20, 0, 10),
                    FontWeight = FontWeights.Bold
                };

                leftStackPanel.Children.Add(managerTextBlock);
                leftStackPanel.Children.Add(playersTextBlock);

                // Stack panel for the right side elements
                var rightStackPanel = new StackPanel
                {
                    Margin = new Thickness(20),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Right
                };

                // Text block to display team position in the table
                var positionTextBlock = new TextBlock
                {
                    Text = $"Position: {team.Position}",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Foreground = Brushes.White,
                    Margin = new Thickness(0, 0, 0, 10)
                };

                // Image element for the badge
                var image = new Image
                {
                    Source = new BitmapImage(new Uri(team.BadgeImagePath, UriKind.RelativeOrAbsolute)),
                    Width = 100,
                    Height = 100,
                    Margin = new Thickness(0, 0, 0, 20)
                };

                // Home button
                var homeButton = new Button
                {
                    Content = "Home",
                    Width = 100,
                    Height = 30,
                    Margin = new Thickness(0, 20, 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Background = Brushes.Aqua,
                    Foreground = Brushes.Purple,
                    BorderBrush = Brushes.Transparent,
                    FontWeight = FontWeights.Bold
                };

                // Click for home button
                homeButton.Click += (sender, e) =>
                {
                    teamInformationControl.Visibility = Visibility.Collapsed;
                };

                // Right stack panel
                rightStackPanel.Children.Add(positionTextBlock);
                rightStackPanel.Children.Add(image);
                rightStackPanel.Children.Add(homeButton);

                DockPanel.SetDock(leftStackPanel, Dock.Left);
                DockPanel.SetDock(rightStackPanel, Dock.Right);

                // Middle content for dock panel
                dockPanel.Children.Add(leftStackPanel);
                dockPanel.Children.Add(rightStackPanel);
                dockPanel.Children.Add(statisticsTextBlock);

                // ScrollViewer for the DockPanel
                scrollViewer.Content = dockPanel;

                // ScrollViewer 
                grid.Children.Add(scrollViewer);

                
                teamInformationControl.Content = grid;

                // ContentControl
                teamInformationControl.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
        private void PlayPremierLeagueThemeSong()
        {
            try
            {
                var mediaPlayer = new MediaPlayer();
                mediaPlayer.Open(new Uri("C:\\Users\\damoc\\OneDrive - Atlantic TU\\Semester 4 (Year 2)\\Object Oriented Development\\Assignment1\\Assignment1\\Theme\\The Official Premier League Anthem (Official Audio).mp3", UriKind.RelativeOrAbsolute));
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}

