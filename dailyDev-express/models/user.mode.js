const mongoose = require("mongoose");

const UserSchema = mongoose.Schema(
  {
    UserName: { Type: String, unique: true, required: true, dropDups: true },
    Password: { Type: String },
    Name: {
      First: String,
      Last: String
    },
    email: { Type: String, unique: true },
    avatar: {
      data: Buffer,
      contentType: String
    },
    description: { Type: String }
  },
  {
    id: true,
    timestamps: true
  }
);

module.exports = mongoose.model("user", UserSchema);
