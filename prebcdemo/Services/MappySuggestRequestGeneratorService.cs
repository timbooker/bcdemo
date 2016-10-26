using System;
using System.Collections.Generic;
using PageJaunesResto.WebAPI.Connectivity.Framework;
using PageJaunesResto.WebAPI.Connectivity.Framework.RequestCommands;
using PageJaunesResto.WebAPI.Connectivity.Framework.RequestCommands.NamingStrategies;
using PageJaunesResto.WebAPI.Connectivity.Framework.RequestCommands.VerbPrefixes;

namespace prebcdemo
{
	// https://suggest.mappy.net/suggest/1.1/suggest?bbox=48.882299830692354%2C2.285885810852051%2C48.8921199394261%2C2.31935977935791&q=23+boulevar&f=all

	public class MappySuggestRequestGeneratorService : RequestGenerator, IMappySuggestRequestGeneratorService
	{
		public const string Bbox = "48.882299830692354%2C2.285885810852051%2C48.8921199394261%2C2.31935977935791";

		public MappySuggestRequestGeneratorService() :
			base("https://suggest.mappy.net/suggest/1.1/", new List<KeyValuePair<string, object>>() { new KeyValuePair<string, object>("bbox", Bbox) },
				new RequestBuilderCommandFactory(new DefaultRestVerbPrefixes(),
				new RestStyleNamingStrategy(), new JsonRequestSerializer()))
		{
		}
	}

}
