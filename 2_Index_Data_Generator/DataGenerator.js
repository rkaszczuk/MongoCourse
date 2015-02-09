for(i=0; i<1000000; i++)
{
    var document = { 
        a: NumberInt(Math.floor(Math.random() * 3) +1),
        b: NumberInt(Math.floor(Math.random() * 3) +1),
        c: NumberInt(Math.floor(Math.random() * 3) +1)
    }
    documentsToAdd.push(document);
    //var a = documentsToAdd.len % 10000;
    
    if(i%bulkInsertCount == 0)
    {
        counter+=bulkInsertCount;
        db.users.insert(documentsToAdd)
        documentsToAdd.length = 0;
    }
}
print("Added "+ counter + " documents")