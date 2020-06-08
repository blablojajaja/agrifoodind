using System;

namespace AgrifoodInd
{
    class Program
    {
        static void Main(string[] args)
        {
			// TODO Auto-generated method stub
			FreshProduct Carrot = new FreshProduct("2018/06/05", 82, "2018/01/10", "United States");
			FreshProduct Onion = new FreshProduct("2018/06/09", 62, "2018/01/01", "Turkey");
			RefrigeratedProduct Potato = new RefrigeratedProduct("2018/06/14", 22, "2018/02/11", "Ireland", 2564, 19.8);
			RefrigeratedProduct Peas = new RefrigeratedProduct("2018/07/22", 56, "2018/03/17", "India", 1518, 13.2);
			RefrigeratedProduct Corn = new RefrigeratedProduct("2018/10/15", 67, "2018/01/18", "Mexico", 3555, 15.4);
			FrozenProductbyWater Tomato = new FrozenProductbyWater("2018/09/10", 24, "2018/04/19", "Mexico", 15.4, 21.2);
			FrozenProductbyWater Radish = new FrozenProductbyWater("2018/08/20", 35, "2018/05/05", "Spain", 20.1, 30.2);
			FrozenProductbyAir Lettuce = new FrozenProductbyAir("2018/11/08", 16, "2018/05/10", "Pakistan", 60.0, 10.0, 35.0, 5.0);
			FrozenProductbyAir Bean = new FrozenProductbyAir("2018/12/13", 81, "2017/12/21", "Mexico", 50.0, 20.0, 25.0, 5.0);

			System.Console.WriteLine(
					"La zanahoria fué envasada el " + Carrot.PackingDate + ", pertenece al lote número " + Carrot.Numberlot + " en " + Carrot.Countryoforigin
					+ "\nLa cebolla fué envasada el " + Onion.PackingDate + ", pertenece al lote número " + Onion.Numberlot + " en " + Onion.Countryoforigin +
					"\nLa Papa fué envasada el " + Potato.PackingDate + ", pertenece al lote número " + Potato.Numberlot + " en " + Potato.Countryoforigin +
					" su código de supervisión es " + Potato.Supervision_code + " y su temperatura recomendada es de" + Potato.Recommended_temperature +
					" grados \nEl chicharo fué envasado el " + Peas.PackingDate + ", pertenece al lote número " + Peas.Numberlot + " en " + Peas.Countryoforigin +
					" su código de supervisión es " + Peas.Supervision_code + " y su temperatura recomendada es de" + Peas.Recommended_temperature +
					" grados \nEl Maíz fué envasado el " + Corn.PackingDate + ", pertenece al lote número " + Corn.Numberlot + " en " + Corn.Countryoforigin +
					" su código de supervisión es " + Corn.Supervision_code + " y su temperatura recomendada es de" + Corn.Recommended_temperature +
					" grados \nEl Tomate fué envasado el " + Tomato.PackingDate + ", pertenece al lote número " + Tomato.Numberlot + " en " + Tomato.Countryoforigin +
					 ", su concentracion consta de " + Tomato.Salinity + " gramos"
							 + "de sal por litro de agua" + "\nEl Rabano fué envasado el " + Radish.PackingDate + ", pertenece al lote número " + Radish.Numberlot + " en " + Radish.Countryoforigin +
					 ", su concentracion consta de " + Radish.Salinity + " gramos "
						 + "de sal por litro de agua" + "\nLa lechuga fué envasada el " + Lettuce.PackingDate + ", pertenece al lote número " + Lettuce.Numberlot + " en " + Lettuce.Countryoforigin +
					", su porcentaje de nitrogeno fue del " + Lettuce.Nitrogen + "%, el de oxigeno de" + Lettuce.Oxygen + "%, el de carbon de " + Lettuce.Carbon
					+ " y el de vapor de agua de " + Lettuce.Watervapor + "%" + "\nEl frijol fué envasado el " + Bean.PackingDate + ", pertenece al lote número " + Bean.Numberlot + " en " + Bean.Countryoforigin +
					", su porcentaje de nitrogeno fue del " + Bean.Nitrogen + "%, el de oxigeno de" + Bean.Oxygen + "%, el de carbon de " + Bean.Carbon
					+ " y el de vapor de agua de " + Bean.Watervapor + "%" + "\nEl apio fué envasado el ");

		}
	}
}
