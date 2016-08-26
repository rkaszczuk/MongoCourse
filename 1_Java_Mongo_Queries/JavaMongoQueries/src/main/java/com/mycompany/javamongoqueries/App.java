package com.mycompany.javamongoqueries;

import com.mongodb.*;
import java.net.UnknownHostException;
import java.util.Arrays;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws UnknownHostException
    {
        MongoClient mongo = new MongoClient( "localhost" , 27017 );
        DB mongoDatabase = mongo.getDB("DATABASE_NAME");
        DBCollection mongoCollection = mongoDatabase.getCollection("COLLECTION_NAME");
        
        
        BasicDBObject document = new BasicDBObject();
        //key-value field
        document.append("key", "value");
        //embedded document
        document.append("embeddedDocument", new BasicDBObject().append("embKey", "embValue"));
        //embedded array
        document.append("embeddedArray", new BasicDBList().addAll(Arrays.asList("arrayValue1", "arrayValue2")));
        
        mongoCollection.insert(document);


        DBObject result = mongoCollection.findOne(new BasicDBObject("key", "value")); //{"key":"value"}
        System.out.println(result);
        DBCursor cursor = mongoCollection.find(new BasicDBObject("key", new BasicDBObject("$gt", "value")));
        //{"key" : {"$gt": "value"}}
        
        while(cursor.hasNext())
        {
            cursor.next();
        }        
    }
}
