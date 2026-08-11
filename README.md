# Grupparbete: Azure Static Web App & Deployment

## Vem gjorde vad?

* **Josef**: 
  * Konfigurerade Azure-miljön (Taggar, RBAC: Contributor-roll till partner).
  * Genomförde deployment av applikationen via Azure CLI.
  * Anpassade spelet för webben (HTML/JS) så det kunde hostas på en Static Web App.

* **Hilal**: 
  * Hanterade budget-delen (Cost Alert) i Azure.
  * Utvecklade spelets originalkod och grundlogik (C# från början, men gjorde om till js för frontenden)
  * Designade spelets mekanik (poängsystem, slumpmässiga spawn-positioner och hastighet).
  * Arbetade med versionshanteringen och pushade originalkoden till GitHub.

## Deployment

Applikationen deployades till Azure Static Web Apps via Azure CLI med följande kommando:

```bash
az staticwebapp create \
  --name V-rtspelApp \
  --resource-group RG-Josef-Al-Husseini-e0aa81-DotNetCloudDeveloper-VT-Mars-Goteborg \
  --source [https://github.com/josefalhusseini/V-rtspel](https://github.com/josefalhusseini/V-rtspel) \
  --location westeurope \
  --branch main \
  --login-with-github

CHECKLISTA
[x] Azure Resursgrupp: Skapad och taggad.

[x] RBAC: Hilal är tillagd som Contributor.

[x] Budget/Cost Alert: Uppsatt i Azure.

[x] GitHub: Repo finns, ni båda har åtkomst och koden ligger där.

[x] README.md: Innehåller vem som gjorde vad + ert CLI-skript.

[x] Deployment: Appen skapades via Azure CLI.

[x] Live-länk: Spelet går att spela i webbläsaren via er Azure-länk.
