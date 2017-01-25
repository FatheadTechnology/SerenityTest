namespace Serene3.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Serene3');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}