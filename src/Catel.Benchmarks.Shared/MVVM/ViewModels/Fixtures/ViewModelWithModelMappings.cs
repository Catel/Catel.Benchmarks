namespace Catel.Benchmarks.MVVM.ViewModels.Fixtures
{
    using Catel.Benchmarks.Fixtures;
    using Catel.Fody;
    using Catel.MVVM;

    public class ViewModelWithModelMappings : ViewModelBase
    {
        public ViewModelWithModelMappings()
        {
            Person = new PersonModel();
        }

        [Model(SupportIEditableObject = false)]
        [Expose(nameof(PersonModel.LastName))]
        public PersonModel Person { get; set; }

        [ViewModelToModel(property: nameof(PersonModel.FirstName))]
        public string FirstName { get; set; }
    }
}
