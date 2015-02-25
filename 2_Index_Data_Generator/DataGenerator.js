var counter = 0
var bulkInsertCount = 50000
var documentsToAdd = []

for(i=0; i<=1000000; i++)
{
    var document = { 
        a: NumberInt(Math.floor(Math.random() * 5) +1),
        b: NumberInt(Math.floor(Math.random() * 5) +1),
        c: NumberInt(Math.floor(Math.random() * 5) +1)
    }
    documentsToAdd.push(document);
    
    if(i%bulkInsertCount == 0)
    {
        counter+=bulkInsertCount;
        db.indexTest.insert(documentsToAdd)
        documentsToAdd = []
    }
}
print("Added "+ counter + " documents")