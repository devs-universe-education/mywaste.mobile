using System.Threading;
using System.Threading.Tasks;
using MyWasteMobile.DAL.DataObjects;

namespace MyWasteMobile.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("MyWasteMobile.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}

