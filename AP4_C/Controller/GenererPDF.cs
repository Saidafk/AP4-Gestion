﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf.Text;
using Aspose.Pdf;
using AP4_C.Model;

namespace AP4_C.Controller
{
    internal class GenererPDF
    {
        public static void CreerPDF(string filePath, int idFacture)
        {
            var facture = ModeleFacture.RetourneFacture(idFacture);
            var commande = ModeleCommande.RetourneCommande(idFacture);

            if (facture == null || commande == null)
            {
                throw new Exception("Erreur lors de la récupération des données de la facture.");
            }

            // Créer un nouveau document PDF
            Document pdfDocument = new Document();

            // Ajouter une page au document
            Page page = pdfDocument.Pages.Add();

            // Ajouter un titre
            TextFragment title = new TextFragment("Facture");
            title.TextState.FontSize = 20;
            title.TextState.FontStyle = FontStyles.Bold;
            title.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            page.Paragraphs.Add(title);

            // Ajouter les informations de la facture
            page.Paragraphs.Add(new TextFragment($"Numéro de facture : {facture.Idfacture}"));
            page.Paragraphs.Add(new TextFragment($"Date de facture : {facture.Datefacture.ToShortDateString()}"));
            page.Paragraphs.Add(new TextFragment($"Table : {commande.Idtable}"));

            // Ajouter un tableau pour les plats commandés
            Table table = new Table
            {
                ColumnWidths = "50% 50%", // Deux colonnes de largeur égale
                Border = new BorderInfo(BorderSide.All, 1f),
                DefaultCellBorder = new BorderInfo(BorderSide.All, 0.5f),
                DefaultCellPadding = new MarginInfo(5, 5, 5, 5)
            };

            // Ajouter les en-têtes du tableau
            Row headerRow = table.Rows.Add();
            headerRow.Cells.Add("Plat");
            headerRow.Cells.Add("Prix");

            // Récupérer les plats commandés
            var platsCommandes = ModeleInstancePlat.listeInstancePlat()
                .Where(x => x.Idcommande == idFacture)
                .Select(x => new
                {
                    NomPlat = ModelePlat.RentourneNomPlat(x.Idplat)?.Libelleplat,
                    PrixPlat = ModelePlat.RentourneNomPlat(x.Idplat)?.Prixplatht
                })
                .ToList();

            // Ajouter les plats au tableau
            decimal totalPrix = 0;
            foreach (var plat in platsCommandes)
            {
                Row row = table.Rows.Add();
                row.Cells.Add(plat.NomPlat ?? "N/A");
                row.Cells.Add(plat.PrixPlat?.ToString("C") ?? "N/A");

                if (plat.PrixPlat.HasValue)
                {
                    totalPrix += (decimal)plat.PrixPlat;
                }
            }

            // Ajouter le tableau à la page
            page.Paragraphs.Add(table);

            // Ajouter le total
            page.Paragraphs.Add(new TextFragment($"Total : {totalPrix:C}")
            {
                HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Right
            });

            // Enregistrer le document PDF
            pdfDocument.Save(filePath);
        }
    }

}

