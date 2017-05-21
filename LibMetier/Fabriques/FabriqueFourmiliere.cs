﻿using System;
using LibAbstraite;
using LibAbstraite.GestionObjets;
using LibMetier.GestionObjets;

namespace LibMetier
{
    public class FabriqueFourmiliere : FabriqueAbstraite
    {
        public override string Title { get; }

        public FabriqueFourmiliere(string Title)
        {
            this.Title = Title;
        }

        public override AccesAbstrait CreerAcces(ZoneAbstraite zdebut, ZoneAbstraite zfin)
        {
            Console.WriteLine("Création d'un accès (Chemin)");
            return  new Chemin(zdebut, zfin);
        }

        public override EnvironnementAbstrait CreerEnvironnement()
        {
            Console.WriteLine("Création d'un environnement (Fourmilière)");
            return new Fourmiliere();
        }
       
        public override ObjetAbstrait CreerObjet(string nom)
        {
            throw new NotImplementedException();
        }

        public override PersonnageAbstrait CreerPersonnage(string nom)
        {
            throw new NotImplementedException();
        }

        public override ZoneAbstraite CreerZone(string nom)
        {
            throw new NotImplementedException();
        }


    }
}
