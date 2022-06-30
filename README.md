# Templator :shipit:

<ins> Template </ins> -- is a function. input -> **Template** -> output (text of the template)

[Project diagrams](https://lucid.app/lucidchart/cbdb698c-a110-4762-ab0f-9bbdb1eed1e0/edit?viewport_loc=-10%2C-10%2C1707%2C821%2C0_0&invitationId=inv_f1f63ead-021f-48e5-93a5-743bb9337ae8#)

[Features](https://docs.google.com/document/d/1g_2gwxhRuaL12-LVc9v_Qsjvmdp_LuD_zviNtVUMqi8/edit#heading=h.7xz6ef1eyr14)

\# - variable in the template

# Ats(dogs)(tags):

> @Input

@Input - user input 

> @Selector

@Selector("inDto") - tag used to get template output in a template.

Usage: @@selectorName

Example: public Task<> Create#EntityName(@@inDto dto)


> @GeneratesFolder

@GeneratesFolder="WebLayer/Dtos/#InDtoFolderName"
Generates folder.

> @GeneratesFile

@GeneratesFile="#EntityName.dto"
{
    public class #EntityName#Dto 
    {
        *for prop in #EntityProperties
        {
            public prop.type prop.name { get; set; }
        }
    }
}

> @TemplateReferences

@TemplateReferences
writes all template references.

> @GeneratesProject

@GeneratesProject="projectName"
