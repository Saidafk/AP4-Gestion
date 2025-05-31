# Application de Gestion de Caisse - CAS MOËL

## Introduction

L'application de gestion de caisse CAS MOËL est une solution multi-plateforme visant à moderniser la gestion des commandes et des réservations dans les établissements de restauration de la commune de Camoël en Bretagne. Elle permet une prise de commande optimisée pour les serveurs et les clients, une gestion efficace des stocks et une interface centralisée pour la cuisine.

## Fonctionnalités Principales

1. Gestion des commandes sur place

- ** Commande au comptoir avec édition instantanée de facture
- ** Suivi des disponibilités des produits en temps réel

2. Gestion des Stocks et Produits
   
- ** Ajout, modification et suppression de produits
- ** Suivi des réapprovisionnements avec historique

3. Édition de Factures

- ** Calcul automatique de la TVA (20%)
- ** Génération de factures détaillées

## Installation

### Prérequis

Avant d’installer l’application, assurez-vous d’avoir les éléments suivants installés sur votre machine :

  Système d’exploitation : 
Windows 10/11 ou Linux (Ubuntu recommandé)

  SDK et frameworks : 
.NET SDK (version minimale : .NET 6 ou 7)
ASP.NET Core
Entity Framework Core

  Base de données :
MySQL Server 
  Autres outils :
Git (pour le versionnement du code)
Visual Studio (ou VS Code avec extensions C#)

Étapes
Cloner le dépôt Git :
Restaurer les dépendances .NET : dotnet restore
Créer un fichier appsettings.Development.json à partir du modèle appsettings.Development.example.json.
Configurer les informations de base de données dans appsettings.Development.json (ConnectionStrings:DefaultConnection).
Appliquer les migrations à la base de données : dotnet ef database update
Lancer le projet ASP.NET Core : dotnet run

## Contributeurs

- Valentin Brosseau
- Carine Autret
