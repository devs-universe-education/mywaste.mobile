using System.Threading;
using System.Threading.Tasks;
using MyWasteMobile.DAL.DataObjects;

namespace MyWasteMobile.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}

