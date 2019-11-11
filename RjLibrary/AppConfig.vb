Imports System.Configuration
Imports System.Reflection
Public Class AppConfig
    Private _config As Configuration
    Private _settings As AppSettingsSection

    Public Function GetProperty(propertyName As String) As String
        Return _settings.Settings.Item(propertyName).Value
    End Function

    Public Sub SetProperty(propertyName As String, propertyValue As String)
        '_settings.Settings.Item(propertyName).Value = propertyValue
        '_config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        '_settings = _config.AppSettings
        _settings.Settings.Item(propertyName).Value = propertyValue
        _config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    Public Sub New()
        ' _config = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location)
        _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        _settings = _config.AppSettings
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        _config.Save(ConfigurationSaveMode.Modified)
    End Sub
End Class
