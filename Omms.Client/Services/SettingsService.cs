using AppSettingsManagement;
using AppSettingsManagement.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omms.Client.Services;

internal partial class SettingsService : SettingsContainer
{

    [SettingItem(typeof(double), "AppWindowHeight", Default = 500, Converter = typeof(JsonStringConverter<double>))]
    [SettingItem(typeof(double), "AppWindowWidth", Default = 950, Converter = typeof(JsonStringConverter<double>))]

    public SettingsService(ISettingsStorage storage) : base(storage)
    {
    }
}
