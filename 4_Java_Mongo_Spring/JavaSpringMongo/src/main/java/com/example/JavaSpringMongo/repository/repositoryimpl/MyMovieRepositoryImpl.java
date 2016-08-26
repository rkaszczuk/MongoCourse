package com.example.JavaSpringMongo.repository.repositoryimpl;

import com.example.JavaSpringMongo.models.Movie;
import com.example.JavaSpringMongo.repository.MyMovieRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.mongodb.core.MongoTemplate;
import org.springframework.data.mongodb.core.query.Criteria;
import org.springframework.data.mongodb.core.query.Query;

/**
 * Created by Rafał on 2015-02-27.
 */
public class MyMovieRepositoryImpl implements MyMovieRepository {
    @Autowired
    private MongoTemplate mongoTemplate;


    public Movie getByName(String name) {
        return mongoTemplate.findOne(new Query(Criteria.where("name").is(name)), Movie.class);
    }
}
