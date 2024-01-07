using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webproje
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private List<string> tournamentPlayers = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                // Redirect to the login page
                Response.Redirect("WebForm2.aspx");
            }
        }
        protected void btnStartTournament_Click(object sender, EventArgs e)
        {
            int playerCount;

            if (int.TryParse(txtPlayerCount.Text, out playerCount))
            {
                if (playerCount > 0)
                {
                    tournamentPlayers.Clear(); // Turnuva başlatıldığında oyuncu listesini temizle

                    for (int i = 1; i <= playerCount; i++)
                    {
                        string playerName = PromptUserForName(i);
                        tournamentPlayers.Add(playerName);
                    }

                    // Turnuvayı başlat
                    StartTournament(tournamentPlayers);
                }
                else
                {
                    lblPlayerCount.Text = "Lütfen geçerli bir pozitif sayı girin.";
                }
            }
            else
            {
                lblPlayerCount.Text = "Lütfen geçerli bir sayı girin.";
            }
        }

        private string PromptUserForName(int playerNumber)
        {
            string promptMessage = string.Format("Lütfen {0}. oyuncunun adını girin:", playerNumber);
            return Microsoft.VisualBasic.Interaction.InputBox(promptMessage, "Oyuncu Adı", "");
        }

        private void StartTournament(List<string> players)
        {
            int round = 1;

            while (players.Count > 1)
            {
                List<string> winners = new List<string>();

                for (int i = 0; i < players.Count; i += 2)
                {
                    string player1 = players[i];
                    string player2 = (i + 1 < players.Count) ? players[i + 1] : "BYE";

                    string winner = SimulateMatch(player1, player2);
                    winners.Add(winner);
                }

                players = winners;
                DisplayRoundResults(round, winners);

                round++;
            }

            // Turnuva sona erdiğinde şampiyonu yazdır
            Response.Write("<h3>Turnuva Sonu!</h3>");
            Response.Write("<p>Şampiyon: " + players[0] + "</p>");
        }

        private string SimulateMatch(string player1, string player2)
        {
            
            Random random = new Random();
            return (random.Next(2) == 0) ? player1 : player2;
        }

        private void DisplayRoundResults(int round, List<string> winners)
        {
            Response.Write(string.Format("<div class=\"round-container\">"));
            Response.Write(string.Format("<h3>{0}. Tur</h3>", round));
            Response.Write("<p>Galip Gelenler:</p>");

            foreach (var winner in winners)
            {
                Response.Write(string.Format("<p class=\"winner\">{0}</p>", winner));
            }

            Response.Write("</div>");
        }
    }
    }
       