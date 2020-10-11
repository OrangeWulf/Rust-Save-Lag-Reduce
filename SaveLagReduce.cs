namespace Oxide.Plugins
{
    // Creation date: 11-10-2020
    // Last update date: UPDATE_DATE
    [Info("Save Lag Reduce", "Orange", "1.0.0")]
    [Description("https://rustworkshop.space/")]
    public class SaveLagReduce : RustPlugin
    {
        private void OnServerSave()
        {
            timer.Once(10f, TimedSave);
        }

        private void TimedSave()
        {
            var last = 0;
            var list = plugins.GetAll();
            timer.Repeat(3f, list.Length, () =>
            {
                var plugin = list[last++];
                plugin.CallHook("OnCustomSave");
            });
        }
    }
}
