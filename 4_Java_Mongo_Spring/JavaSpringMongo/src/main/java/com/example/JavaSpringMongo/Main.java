package com.example.JavaSpringMongo;
import com.example.JavaSpringMongo.models.User;
import com.mongodb.MongoClient;
import com.mongodb.WriteResult;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.data.mongodb.core.MongoOperations;
import org.springframework.data.mongodb.core.MongoTemplate;
import org.springframework.data.mongodb.core.aggregation.Aggregation;
import org.springframework.data.mongodb.core.aggregation.AggregationResults;
import org.springframework.data.mongodb.core.query.Criteria;
import org.springframework.data.mongodb.core.query.Query;
import org.springframework.data.mongodb.core.query.Update;
import com.mongodb.util.JSON;

import static org.springframework.data.mongodb.core.aggregation.Aggregation.group;
import static org.springframework.data.mongodb.core.aggregation.Aggregation.newAggregation;

public class Main {
    public static final String MONGO_IP = "127.0.0.1";
    public static final int MONGO_PORT = 27017;
    public static final String MONGO_DBNAME = "DBTEST";



    public static void main(String[] args) throws Exception{

        /*MongoClient mongoClient = new MongoClient(MONGO_IP, MONGO_PORT);
        MongoOperations mongoOpp = new MongoTemplate(mongoClient, MONGO_DBNAME);

        //insert
        mongoOpp.insert(new User("Anne", 22));
        mongoOpp.insert(new User("Ben", 35));
        mongoOpp.insert(new User("Paul", 65));

        //findAll
        System.out.println(mongoOpp.findAll(User.class));

        //find
        System.out.println(mongoOpp.findOne(new Query(Criteria.where("name").is("Ben")), User.class));

        System.out.println(mongoOpp.find(new Query(Criteria.where("age").gt(40)), User.class));

        Criteria criteria = new Criteria().andOperator(Criteria.where("age").lt(50), Criteria.where("age").gt(30));
        System.out.println(mongoOpp.find(new Query(criteria), User.class));

        //count
        System.out.println(mongoOpp.count(new Query(), User.class));

        //update - set
        WriteResult writeResult = mongoOpp.updateFirst(new Query(Criteria.where("name").is("Anne")), new Update().set("age", 32), User.class);
        System.out.println(writeResult.isUpdateOfExisting());

        writeResult = mongoOpp.updateFirst(new Query(Criteria.where("name").is("Anne2")), new Update().set("age", 32), User.class);
        System.out.println(writeResult.isUpdateOfExisting());

        //update - inc
        mongoOpp.updateMulti(new Query(), new Update().inc("age", -20), User.class);
        System.out.println(mongoOpp.findAll(User.class));

        //aggregate
        mongoOpp.insert(new User("Anne", 30));

        Aggregation agg = newAggregation(group("name").count().as("count"));
        AggregationResults<UserAggregationResult> aggResult =  mongoOpp.aggregate(agg, User.class, UserAggregationResult.class);
        System.out.println(aggResult.getMappedResults());*/


        ClassPathXmlApplicationContext ctx = new ClassPathXmlApplicationContext("spring.xml");


        SpringMongoMain springMongoMain = ctx.getBean("springMongoMain", SpringMongoMain.class);
        springMongoMain.run();

        //mongoOpp.dropCollection(User.class);
        ctx.close();
    }


    private class UserAggregationResult{
        private String id;
        private Integer count;

        public String getId() {
            return id;
        }

        public void setId(String id) {
            this.id = id;
        }

        public Integer getCount() {
            return count;
        }

        public void setCount(Integer count) {
            this.count = count;
        }

        @Override
        public String toString() {
            return "UserAggregationResult{" +
                    "id='" + id + '\'' +
                    ", count=" + count +
                    '}';
        }
    }


}
