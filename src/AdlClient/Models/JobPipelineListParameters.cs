namespace AdlClient.Models
{
    public class JobPipelineListParameters
    {
        // 100 is picked as the default number of records to 
        // retrieve so that callers are overwhelmed with data on first use

        public int Top = 100;
        public AdlClient.Models.RangeDateTime DateRange;

        public JobPipelineListParameters()
        {
        }
    }
}