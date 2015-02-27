package com.example.JavaSpringMongo.repository;

import com.example.JavaSpringMongo.models.User;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;


/**
 * Created by Rafał on 2015-02-27.
 */
//public interface UserRepository  extends Repository<User, String> {
@Repository
public interface UserRepository  extends CrudRepository<User, String> {
    public User findByName(String name);
}
