namespace webAPISecSess.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<webAPISecSess.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(webAPISecSess.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "SuperPowerUser",
                Email = "taiseer.joudeh@mymail.com",
                EmailConfirmed = true,
                FirstName = "Taiseer",
                LastName = "Joudeh",
            };

            manager.Create(user, "MySuperP@ssword!");

            Transport transp1 = new Transport()
            {
                Id_Transport = 1,
                TransportName = "Marche",
                Speed = 5,
            };

            Transport transp2 = new Transport()
            {
                Id_Transport = 2,
                TransportName = "V�lo",
                Speed = 15,
            };
            Transport transp3 = new Transport()
            {
                Id_Transport = 3,
                TransportName = "Voiture",
                Speed = 50,
            };

            Category categ1 = new Category()
            {
                Id_Category = 1,
                CategoryName = "Sportive",
                Description = "D�nivellation plus importante"
            };

            Category categ2 = new Category()
            {
                Id_Category = 2,
                CategoryName = "Romantique",
                Description = "Promenade en amoureux. Paisible et idylique pour les couples. Possibilit� de passer du temps � deux en toute tranquillit�."
            };

            Category categ3 = new Category()
            {
                Id_Category = 3,
                CategoryName = "D�couverte",
                Description = "Visite des sites touristiques principaux de la ville."
            };

            Category categ4 = new Category()
            {
                Id_Category = 4,
                CategoryName = "Familiale",
                Description = "Parfait pour passer du temps en famille. Parcours adapt�s pour les plus grands comme pour les plus petits."
            };

            Category categ5 = new Category()
            {
                Id_Category = 5,
                CategoryName = "Culturel",
                Description = "Tour des mus�es Namurois"
            };

            PlaceToEat placetoeat1 = new PlaceToEat()
            {
                Id_PlaceToEat = 1,
                PlaceToEatName = "Les Sens du Go�t",
                Latitude = 50.4661309,
                Longitude = 4.849598399999991,
                Address = "Rue des Bas Pr�s 52, 5000 Namur",
                Id_Photo = "1",
                Price_Min = 15,
                Price_Max = 100
            };

            PlaceToEat placetoeat2 = new PlaceToEat()
            {
                Id_PlaceToEat = 2,
                PlaceToEatName = "Piccolo Sibila",
                Latitude = 50.4644828,
                Longitude = 4.863955099999998,
                Address = "Rue Haute Marcelle 15, 5000 Namur",
                Id_Photo = "2",
                Price_Min = 15,
                Price_Max = 50
            };

            TouristPlace place1 = new TouristPlace()
            {
                Id_TouristPlace = 1,
                Latitude = 50.463385,
                Longitude = 4.8627025000000685,
                TouristPlaceName = "Mus�e F�licien Rops",
                Address = "Rue Fumal, 12 5000 Namur",
                Description = "L'exposition permanente offre une approche compl�te de l'oeuvre de Rops dans sa diversit� : les d�buts dans la satire sociale et la caricature, la lithographie, l'esprit baudelairien, la vie parisienne, l�omnipr�sence de la femme, la mort, l��rotisme, les liens avec le monde litt�raire, les voyages� Outre cette collection permanente, le mus�e accueille �galement des expositions temporaires abordant les th�mes du XIXe si�cle, d�artistes-graveurs contemporains belges et �trangers, etc. Possibilit�s de nombreuses animations p�dagogiques.",
                Time = 60,
                Id_Photo = "1.jpg",
                Price = 3
            };

            TouristPlace place2 = new TouristPlace()
            {
                Id_TouristPlace = 2,
                Latitude = 50.466604,
                Longitude = 4.8708871000000045,
                TouristPlaceName = "Mus�e Africain",
                Address = "Rue du 1er Lanciers, 1 5000 Namur",
                Description = "la description du Mus�e devrait �tre : H�berg� dans le corps de garde de l�ancienne caserne L�opold (1885), le Mus�e, unique institution du genre en Wallonie, pr�sente des documents et souvenirs li�s � la pr�sence belge en Afrique centrale, essentiellement au Congo. Une biblioth�que de 20.000 livres et p�riodiques couvre l�histoire, la g�ographie, la zoologie, la g�ologie, l�ethnographie, l��conomie...",
                Time = 60,
                Id_Photo = "2.jpg",
                Price = 3
            };

            TouristPlace place3 = new TouristPlace()
            {
                Id_TouristPlace = 3,
                Latitude = 50.4444056,
                Longitude = 4.87806599999999,
                TouristPlaceName = "Mus�e du G�nie",
                Address = "Chemin du Masuage 5100 Jambes",
                Description = "Toute l'histoire du g�nie militaire, de Vauban � nos jours. De nombreux objets, documents, mannequins et maquettes ainsi qu'une exposition d'anciens engins de construction routi�re, de pontage ou de combat, rappellent le r�le fondamental du g�nie : � Parfois d�truire, souvent construire, toujours servir �.",
                Time = 60,
                Id_Photo = "3.jpg",
                Price = 5
            };

            TouristPlace place4 = new TouristPlace()
            {
                Id_TouristPlace = 4,
                Latitude = 50.4588001,
                Longitude = 4.86218550000001,
                TouristPlaceName = "Citadelle de Namur",
                Address = "Route Merveilleuse 64, 5000 Namur",
                Description = "La citadelle de Namur, en Belgique est divis�e en trois parties : Donjon, repr�sentant la partie inf�rieure, M�diane pour la partie interm�diaire et Terra Nova pour la partie sup�rieure. Son sommet culmine � 190 m d'altitude.",
                Time = 120,
                Id_Photo = "4.jpg",
                Price = 0
            };

            TouristPlace place5 = new TouristPlace()
            {
                Id_TouristPlace = 5,
                Latitude = 50.4645959,
                Longitude = 4.860694599999988,
                TouristPlaceName = "Cath�drale Saint-Aubain de Namur",
                Address = "Place du Chapitre 4, 5000 Namur",
                Description = "La cath�drale Saint-Aubain de Namur est un �difice religieux catholique qui est l'�glise �piscopale et si�ge du dioc�se de Namur. Commenc�e en 1751, son �dification se termine en 1767. La cons�cration a eu lieu le 20 septembre 1772",
                Time = 30,
                Id_Photo = "5.jpg",
                Price = 0
            };

            TouristPlace place6 = new TouristPlace()
            {
                Id_TouristPlace = 6,
                Latitude = 50.5081885,
                Longitude = 4.856186999999977,
                TouristPlaceName = "Fort d'�mines",
                Address = "Rue du Fort d'Emines, 5000 Namur",
                Description = "Le fort d'Emines construit entre les villages d'�mines et de Saint-Marc, est l'un des 9 forts construit entre 1888 et 1892 autour de Namur en Belgique conjointement � ceux de Li�ge afin de d�fendre la neutralit� du pays contre les vell�it�s fran�aises (ou allemandes pour Li�ge) qui �taient susceptibles d'emprunter la vall�e de la Meuse pour s'envahir l'un l'autre en bafouant la neutralit� Belge au passage. Tous ces forts ont �t� con�us par le g�n�ral Henri Alexis Brialmont et mettent en �uvre un b�ton non arm�, mat�riau assez novateur � l'�poque. Il est positionn� au nord de la ville et est consid�r� comme l'un des petits forts de la ceinture namuroise.",
                Time = 60,
                Id_Photo = "6.jpg",
                Price = 0
            };

            TouristPlace place7 = new TouristPlace()
            {
                Id_TouristPlace = 7,
                Latitude = 50.4645552,
                Longitude = 4.856444499999952,
                TouristPlaceName = "Beffroi de Namur",
                Address = "Rue Ch�teau des 4 Seigneurs 8, 5020 Namur",
                Description = "C'est une tour en pierre circulaire � l'origine appel�e Tour de Saint Jacques et d�clar�e Patrimoine de l'Humanit� par l'Unesco en 1999. Sa construction a commenc� en 1388 et son aspect actuel date du XVI�me si�cle. Apr�s la destruction en 1745 de l'�glise de Saint Pierre de la citadelle et sa tour en 1841, elle a �t� transform�e en horloge municipale. Elle abrite aujourd'hui des expositions d'art temporaires.",
                Time = 45,
                Id_Photo = "7.jpg",
                Price = 0
            };

            TouristPlace place8 = new TouristPlace()
            {
                Id_TouristPlace = 8,
                Latitude = 50.4638187,
                Longitude = 4.862052500000004,
                TouristPlaceName = "�glise Saint-Loup",
                Address = "Rue du Coll�ge, 5000 Namur",
                Description = "Cette �glise est un des principaux monuments de Namur et un chef-d'oeuvre de style baroque en Belgique, qu'aimait beaucoup Baudelaire. Cette �glise �tait le couvent des j�suites, construit entre 1621 et 1645, un bel exemple de l'architecture religieuse du XVII�me. L'int�rieur surprend par les magnifiques motifs floraux en marbre.",
                Time = 30,
                Id_Photo = "8.jpg",
                Price = 0
            };

            TouristPlace place9 = new TouristPlace()
            {
                Id_TouristPlace = 9,
                Latitude = 50.4684683,
                Longitude = 4.86253320000003,
                TouristPlaceName = "Namourette",
                Address = "Place de la Station, 5000 Namur",
                Description = "Une Namourette est un petit bateau de transport de passagers qui navigue sur la Meuse et la Sambre, entre Jambes et Salzinnes. Son nom est une r�f�rence � sa ville d'adoption, Namur, et � ses grands fr�res v�nitiens.",
                Time = 15,
                Id_Photo = "9.jpg",
                Price = 1
            };

            TouristPlace place10 = new TouristPlace()
            {
                Id_TouristPlace = 10,
                Latitude = 50.46454360000001,
                Longitude = 4.868012399999998,
                TouristPlaceName = "Th��tres royal de Namur",
                Address = "Place du Th��tre 2, 5000 Namur",
                Description = "C'est un b�timent magnifique qui a �t� d�truit apr�s un incendie et qui a �t� reconstruit en style italien en 1863. Il est fait en pierre sablonneuse, mat�rielle tr�s rare � trouver dans la r�gion. A l'int�rieur, il dispose de plusieurs moyens techniques les plus modernes. Garouster, un peintre fran�ais, a d�cor� les plafonds de l'entr�e de ce th��tre somptueux. Plusieurs bars ont leurs terrasses dans l'entr�e, et c'est agr�able de prendre un rafra�chissement � leurs portes.",
                Time = 45,
                Id_Photo = "10.jpg",
                Price = 30
            };

            GuidedTour route1 = new GuidedTour()
            {
                Id_GuidedTour = 1,
                GuidedTourName = "Tourn�e des mus�es",
                Distance = 15,
                Id_Transport = 3,
                Id_Category = 5,
                Id_PlaceToEat = 1
            };

            GuidedTour route2 = new GuidedTour()
            {
                Id_GuidedTour = 2,
                GuidedTourName = "Au bord de l'eau",
                Distance = 7,
                Id_Transport = 1,
                Id_Category = 2,
                Id_PlaceToEat = 1
            };

            GuidedTour route3 = new GuidedTour()
            {
                Id_GuidedTour = 3,
                GuidedTourName = "L'ascension",
                Distance = 10,
                Id_Transport = 1,
                Id_Category = 1,
                Id_PlaceToEat = 2
            };

            GuidedTour route4 = new GuidedTour()
            {
                Id_GuidedTour = 4,
                GuidedTourName = "La familiale ",
                Distance = 5,
                Id_Transport = 1,
                Id_Category = 4,
                Id_PlaceToEat = 2
            };

            GuidedTour route5 = new GuidedTour()
            {
                Id_GuidedTour = 5,
                GuidedTourName = "Le cycliste ",
                Distance = 20,
                Id_Transport = 2,
                Id_Category = 2,
                Id_PlaceToEat = 2
            };

            PlaceWithOrder compo1 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 1,
                Id_GuidedTour = 1,
                Id_TouristPlace = 1,
                OrderNumber = 1

            };

            PlaceWithOrder compo2 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 2,
                Id_GuidedTour = 1,
                Id_TouristPlace = 2,
                OrderNumber = 2

            };

            PlaceWithOrder compo3 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 3,
                Id_GuidedTour = 1,
                Id_TouristPlace = 3,
                OrderNumber = 3

            };

            PlaceWithOrder compo4 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 4,
                Id_GuidedTour = 2,
                Id_TouristPlace = 9,
                OrderNumber = 1

            };

            PlaceWithOrder compo5 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 5,
                Id_GuidedTour = 2,
                Id_TouristPlace = 10,
                OrderNumber = 2

            };

            PlaceWithOrder compo6 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 6,
                Id_GuidedTour = 2,
                Id_TouristPlace = 8,
                OrderNumber = 3
            };

            PlaceWithOrder compo7 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 7,
                Id_GuidedTour = 2,
                Id_TouristPlace = 7,
                OrderNumber = 4
            };

            PlaceWithOrder compo8 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 8,
                Id_GuidedTour = 2,
                Id_TouristPlace = 5,
                OrderNumber = 5
            };

            PlaceWithOrder compo9 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 9,
                Id_GuidedTour = 3,
                Id_TouristPlace = 10,
                OrderNumber = 1
            };

            PlaceWithOrder compo10 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 10,
                Id_GuidedTour = 3,
                Id_TouristPlace = 6,
                OrderNumber = 2
            };

            PlaceWithOrder compo11 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 11,
                Id_GuidedTour = 3,
                Id_TouristPlace = 5,
                OrderNumber = 3
            };

            PlaceWithOrder compo12 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 12,
                Id_GuidedTour = 3,
                Id_TouristPlace = 4,
                OrderNumber = 4
            };

            PlaceWithOrder compo13 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 13,
                Id_GuidedTour = 4,
                Id_TouristPlace = 10,
                OrderNumber = 1
            };

            PlaceWithOrder compo14 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 14,
                Id_GuidedTour = 4,
                Id_TouristPlace = 8,
                OrderNumber = 2
            };

            PlaceWithOrder compo15 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 15,
                Id_GuidedTour = 4,
                Id_TouristPlace = 7,
                OrderNumber = 3
            };

            PlaceWithOrder compo16 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 16,
                Id_GuidedTour = 5,
                Id_TouristPlace = 4,
                OrderNumber = 1
            };

            PlaceWithOrder compo17 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 17,
                Id_GuidedTour = 5,
                Id_TouristPlace = 5,
                OrderNumber = 2
            };

            PlaceWithOrder compo18 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 18,
                Id_GuidedTour = 5,
                Id_TouristPlace = 6,
                OrderNumber = 3
            };

            PlaceWithOrder compo19 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 19,
                Id_GuidedTour = 5,
                Id_TouristPlace = 7,
                OrderNumber = 4
            };

            PlaceWithOrder compo20 = new PlaceWithOrder()
            {
                Id_PlaceWithOrder = 20,
                Id_GuidedTour = 5,
                Id_TouristPlace = 8,
                OrderNumber = 5
            };

            context.TransportSet.Add(transp1);
            context.TransportSet.Add(transp2);
            context.TransportSet.Add(transp3);

            context.PlacesToEatSet.Add(placetoeat1);
            context.PlacesToEatSet.Add(placetoeat2);

            context.TouristPlaceSet.Add(place1);
            context.TouristPlaceSet.Add(place2);
            context.TouristPlaceSet.Add(place3);
            context.TouristPlaceSet.Add(place4);
            context.TouristPlaceSet.Add(place5);
            context.TouristPlaceSet.Add(place6);
            context.TouristPlaceSet.Add(place7);
            context.TouristPlaceSet.Add(place8);
            context.TouristPlaceSet.Add(place9);
            context.TouristPlaceSet.Add(place10);

            context.CategorySet.Add(categ1);
            context.CategorySet.Add(categ2);
            context.CategorySet.Add(categ3);
            context.CategorySet.Add(categ4);
            context.CategorySet.Add(categ5);

            context.GuidedTourSet.Add(route1);
            context.GuidedTourSet.Add(route2);
            context.GuidedTourSet.Add(route3);
            context.GuidedTourSet.Add(route4);
            context.GuidedTourSet.Add(route5);

            context.PlaceWithOrderSet.Add(compo1);
            context.PlaceWithOrderSet.Add(compo2);
            context.PlaceWithOrderSet.Add(compo3);
            context.PlaceWithOrderSet.Add(compo4);
            context.PlaceWithOrderSet.Add(compo5);
            context.PlaceWithOrderSet.Add(compo6);
            context.PlaceWithOrderSet.Add(compo7);
            context.PlaceWithOrderSet.Add(compo8);
            context.PlaceWithOrderSet.Add(compo9);
            context.PlaceWithOrderSet.Add(compo10);
            context.PlaceWithOrderSet.Add(compo11);
            context.PlaceWithOrderSet.Add(compo12);
            context.PlaceWithOrderSet.Add(compo13);
            context.PlaceWithOrderSet.Add(compo14);
            context.PlaceWithOrderSet.Add(compo15);
            context.PlaceWithOrderSet.Add(compo16);
            context.PlaceWithOrderSet.Add(compo17);
            context.PlaceWithOrderSet.Add(compo18);
            context.PlaceWithOrderSet.Add(compo19);
            context.PlaceWithOrderSet.Add(compo20);

            context.SaveChanges();
        }
    }
}
