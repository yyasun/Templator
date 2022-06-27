# Templator
Project generator

<ins> Template </ins> -- is a function. input -> **Template** -> output (text of the template)

/# - variable in the template
# Ats(dogs):

## @Input
@Input - 

## @Selector
@Selector("inDto") - tag used to get template output in a template. 
Usage:
@@selectorName
Example:
public Task<> Create#EntityName(@@inDto dto)


## @GeneratesFolder
@GeneratesFolder="WebLayer/Dtos/#InDtoFolderName"
Generates folder.

## @GeneratesFile
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

## @TemplateReferences
@TemplateReferences
writes all template references.
## @GeneratesProject
@GeneratesProject="projectName"