// See https://aka.ms/new-console-template for more information
using GameProject;

GamerManager gamerManager = new GamerManager(new EDevlet());
gamerManager.Add(new Gamer { Id = 1, BirthYear=2000, FirstName="Yakup", LastName="Bingöl", IdentityNumber=192021 });
gamerManager.Update(new Gamer { Id = 2, BirthYear = 2001, FirstName = "Serhat", LastName = "Gürleyen", IdentityNumber = 202122 });
gamerManager.Delete(new Gamer { Id = 1, BirthYear = 2000, FirstName = "Yakup", LastName = "Bingöl", IdentityNumber = 192021 });
OfferManager offerManager = new OfferManager(new EDevlet());
offerManager.Add(new Gamer { });
offerManager.Delete(new Gamer { });
offerManager.Update(new Gamer { });

