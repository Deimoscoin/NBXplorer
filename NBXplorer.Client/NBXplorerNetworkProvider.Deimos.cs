using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitDeimos(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Deimos.Instance, networkType)
			{
				MinRPCVersion = 100300
			});
		}

		public NBXplorerNetwork GetDEI()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Deimos.Instance.CryptoCode);
		}
	}
}
