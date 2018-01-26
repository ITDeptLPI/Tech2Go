using Unity.Builder.Operation;
using Prism.Mvvm;

namespace Tech2Go.Model {
	public class BaseProduct {
		public int Id { get; set; }
		public string ModelName { get; set; }
		public string PhotoFile { get; set; }
	}
}