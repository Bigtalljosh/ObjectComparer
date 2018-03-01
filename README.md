# ObjectComparer
A static function I wrote to compare two objects and list you the differences. This was really useful for a project I worked on where a slight difference in the JSON produced (Usually due to some dirty legacy data in our system) could result in a generic error returned from the third party API. As you can imagine this became a bit of a nightmare to debug as the objects got larger. 

At present I've only got this to work for simplistic objects. I have been pondering how to improve for complex objects and I think my solution will be to serialise both objects and perform a diff. I'll update when I give it a go...
