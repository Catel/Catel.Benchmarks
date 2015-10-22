# Catel.Benchmarks

Benchmarks for Catel classes so they can be compared.

## How to run benchmarks

To run the benchmarks, run the unit tests and the UI should automatically open. For more information about 
NUnitBenchmarker, see https://github.com/Orcomp/NUnitBenchmarker.

## Troubleshooting

### No endpoint listening

When you get the error:


	SetUp : System.ServiceModel.EndpointNotFoundException : There was no endpoint listening at http://localhost:8091/NUnitBenchmarker/UIService that could accept the message. This is often caused by an incorrect address or SOAP action. See InnerException, if present, for more details.
		----> System.Net.WebException : Unable to connect to the remote server
		----> System.Net.Sockets.SocketException : No connection could be made because the target machine actively refused it 127.0.0.1:8091
		
You need to run this script as administrator:
		
	netsh http add urlacl url=http://+:8091/NUnitBenchmarker/UIService/ user=Everyone

If your firewall is complaining:

	netsh advfirewall firewall add rule name="NUnitBenchmarker" dir=in action=allow protocol=TCP localport=8091