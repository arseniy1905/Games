namespace Games.DataModel.SP.Params
{
    public class GetTaggedProductDataDrivenParams : GetTaggedProductParams
    {
        public GetTaggedProductDataDrivenParams()
        {
            Rules = "";
        }
        public string Rules { get; set; }
        public bool All { get; set; }
    }
}
