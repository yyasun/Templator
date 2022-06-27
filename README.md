# Templator
Project generator

<ins> Template </ins> -- is a function. input -> **Template** -> output (text of the template)


# Ats(dogs):

## @Input
@Input - 

## @Selector
@Selector("inDto") - 

## @GeneratesFolder
@GeneratesFolder="WebLayer/Dtos/#InDtoFolderName"


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
